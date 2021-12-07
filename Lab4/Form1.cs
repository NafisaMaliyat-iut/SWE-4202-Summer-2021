using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class LibraryWithStudyBooksAndJournalApp : Form
    {
        public LibraryWithStudyBooksAndJournalApp()
        {
            InitializeComponent();
        }

        List<StudyBooks> StudyBookList = new List<StudyBooks>();    
        List <ResearchArticle> ResearchArticleList = new List<ResearchArticle>();

        private void AddStudyBookButtonOnClick(object sender, EventArgs e)
        {

            StudyBooks dummyStudyBook = new StudyBooks();
            dummyStudyBook.setPublisher(StudyBookPublisherTextBox.Text);
            dummyStudyBook.setAuthor(StudyBookAuthorTextBox.Text);
            dummyStudyBook.setID(Convert.ToInt32(StudyBookIDTextBox.Text));
            dummyStudyBook.setQuantity(Convert.ToInt32(StudyBookQuantityTextBox.Text));
            dummyStudyBook.setTitle(StudyBookTitleTextBox.Text);
            dummyStudyBook.setStudyBookISBN(Convert.ToInt32(StudyBookIsbnTextBox.Text));
            dummyStudyBook.setStudyBookGenre(StudyBookGenreTextBox.Text);

            StudyBookList.Add(dummyStudyBook);

            MessageBox.Show("Study Book Saved Successfully!");

            StudyBookIDTextBox.Text = String.Empty;
            StudyBookTitleTextBox.Text = String.Empty ;
            StudyBookAuthorTextBox.Text = String.Empty;
            StudyBookPublisherTextBox.Text = String .Empty ;
            StudyBookQuantityTextBox.Text = String .Empty ;
            StudyBookIsbnTextBox.Text = String.Empty;
            StudyBookGenreTextBox.Text  =String .Empty ;

        }

        private void AddResearchArticleButtonOnClick(object sender, EventArgs e)
        {

            ResearchArticle dummyResearchArticle = new ResearchArticle();
            dummyResearchArticle.setPublisher(ResearchArticlePublisherTextBox.Text);
            dummyResearchArticle.setAuthor(ResearchArticleAuthorTextBox.Text);
            dummyResearchArticle.setID(Convert.ToInt32(ResearchArticleIDTextBox.Text));
            dummyResearchArticle.setQuantity(Convert.ToInt32(ResearchArticleQuantityTextBox.Text));
            dummyResearchArticle.setTitle(ResearchArticleTitleTextBox.Text);
            dummyResearchArticle.setDOI(ResearchArticleDOITextBox.Text);
            dummyResearchArticle.setPublishedDate(ResearchArticlePublishedDateTextBox.Text);
            dummyResearchArticle.setConferenceOrJournal(Convert.ToChar(ResearchArticleConferenceOrJournalTextBox.Text));

            ResearchArticleList.Add(dummyResearchArticle);

            MessageBox.Show("Research Article Saved Successfully!");

            ResearchArticleAuthorTextBox.Text = String.Empty;
            ResearchArticleConferenceOrJournalTextBox.Text = String.Empty;
            ResearchArticleDOITextBox.Text = String.Empty;  
            ResearchArticleIDTextBox.Text = String.Empty;
            ResearchArticlePublishedDateTextBox.Text = String.Empty;
            ResearchArticleQuantityTextBox.Text = String.Empty;
            ResearchArticleTitleTextBox.Text = String.Empty;    
            ResearchArticlePublisherTextBox.Text = String.Empty;
        }

        private void ShowStudyBookButtonOnClick(object sender, EventArgs e)
        {
            listBoxStudyBook.Items.Clear();
            listBoxStudyBook.Items.Add("ID\t\tTitle\t\tAuthor\t\tPublisher\t\tQuantity\t\tISBN\t\tGenre");
            foreach (StudyBooks studybook in StudyBookList)
{
                listBoxStudyBook.Items.Add(studybook.getStudyBookInfo());
            }
        }

        private void ShowResearchArticleButtonOnClick(object sender, EventArgs e)
        {
            listBoxResearchArticle.Items.Clear();
            listBoxResearchArticle.Items.Add("ID\t\tTitle\t\tAuthor\t\tPublisher\t\tQuantity\t\tDOI\t\tP.Date\t\tC/J");
            foreach (ResearchArticle researchArticle in ResearchArticleList)
            {
                listBoxResearchArticle.Items.Add(researchArticle.getResearchArticleInfo());
            }
        }

        private void borrowResearchArticleButtonOnClick(object sender, EventArgs e)
        {
            bool articleFound = false;
            foreach(ResearchArticle researchArticle in ResearchArticleList)
            {
                if (researchArticle.getID() == Convert.ToInt32(borrowResearchArticleIDTextBox.Text)) 
                {
                    articleFound = true;
                    int articleQuantity = researchArticle.getQuantity();

                    // article quantiy is more than 0 --> borrowable
                    if(articleQuantity > 0)
                    {
                        
                        researchArticle.setQuantity(articleQuantity-1);
                        MessageBox.Show("Article borrowed successfully!");
                        
                    }

                    //if article quantity is 0
                        
                    else
                    {
                        MessageBox.Show("Article cannot be borrowed!");
                    }
                    break;
                    
                }
            }

            //if ID is not matched
            if (articleFound == false)
                MessageBox.Show("Article is not available!");

           
        }

        private void BorrowStudyBookButtonOnClick(object sender, EventArgs e)
        {
            bool bookFound = false;
            foreach (StudyBooks studyBook in StudyBookList)
            {
                
                // if ID is matched
                if (studyBook.getID() == Convert.ToInt32(borrowStudyBookIDTextBox.Text))
                {
                    bookFound = true;
                    int bookQuantity = studyBook.getQuantity();

                    //if book quantity is more than 0 --> borrowable
                    if (bookQuantity > 0)
                    {

                        studyBook.setQuantity(bookQuantity-1);
                        MessageBox.Show("Book borrowed successfully!");
                        
                    }

                    //if book quantity is 0 

                    else
                    {
                        MessageBox.Show("Book cannot be borrowed!");
                    }
                    break;
                }

                
            }

            //if ID is not matched
            if (bookFound == false)
                MessageBox.Show("Book is not available!");

            borrowStudyBookIDTextBox.Text = String.Empty;
        }

        
    }
}
