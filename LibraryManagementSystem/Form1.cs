using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibraryManagementSystem : Form
    {
        public LibraryManagementSystem()
        {
            InitializeComponent();
        }

        List<Users> userList = new List<Users>();
        List<Books> bookList = new List<Books>();


        private void SaveUserInfoOnClick(object sender, EventArgs e)
        {
            bool DoesUserExist = false;

            foreach(Users user in userList)
            {
                if(Convert.ToInt32(EnterUserIDToAdd.Text) == user.userID)
                {
                    DoesUserExist = true;
                    MessageBox.Show("User already exists!");
                }
            }
            
            if(!DoesUserExist)
            {
                Users dummyUser = new Users()
                {
                    userID = Convert.ToInt32(EnterUserIDToAdd.Text),
                    userName = EnterUserNameToAdd.Text,
                    userAddress = EnterUserAddressToAdd.Text,
                };

                userList.Add(dummyUser);

                MessageBox.Show("User added!");
            }

            EnterUserAddressToAdd.Text = string.Empty;
            EnterUserNameToAdd.Text = string.Empty;
            EnterUserIDToAdd.Text = string.Empty;
        }

        private void AddBookInfoOnClick(object sender, EventArgs e)
        {
            bool doesBookIdExist = false;
            foreach (Books book in bookList)
            {
                if(Convert.ToInt32(EnterBookIDToAdd.Text) == book.bookID)
                {
                    MessageBox.Show("Book already exists!");
                    doesBookIdExist = true;
                }
            }
            if(!doesBookIdExist)
            {
                Books dummyBook = new Books()
                {
                    bookAuthor = EnterBookAuthorToAdd.Text,
                    bookID = Convert.ToInt32(EnterBookIDToAdd.Text),
                    bookName = EnterBookNameToAdd.Text,
                    bookPublisher = EnterBookPublisherToAdd.Text,
                    bookQuantity = Convert.ToInt32(EnterBookQuantityToAdd.Text),

                };

                bookList.Add(dummyBook);
                MessageBox.Show("Book added!");
            }
            

            

            EnterBookAuthorToAdd.Text = string.Empty;
            EnterBookIDToAdd.Text = string.Empty;
            EnterBookNameToAdd.Text = string.Empty;
            EnterBookPublisherToAdd.Text = string.Empty;
            EnterBookQuantityToAdd.Text = string.Empty;
        }
        
        private void ShowBookHistoryOnClick(object sender, EventArgs e)
        { 
            bool bookFound = false;

            foreach (Books book in bookList)
            {

                if (book.bookID == Convert.ToInt32(EnterBookIDToSearch.Text))
                {
                    bookFound = true;
                    showHistoryBookID.Text = Convert.ToString(book.bookID);
                    showHistoryBookTitle.Text = book.bookName;
                    showHistoryBookPublisher.Text = book.bookPublisher;
                    showHistoryBookQuantity.Text = Convert.ToString(book.bookQuantity);
                    showHistoryBookAuthor.Text = book.bookAuthor;

                    break;
                }
            }
            if (!bookFound)
                MessageBox.Show("Book does not exist!");
        }

        private void ShowUserHistoryOnClick(object sender, EventArgs e)
        {
            ListBoxUserHistory.Items.Clear();
            bool userFound = false;
            Users dummy = new Users();
            foreach(Users user in userList)
            {
                if (Convert.ToInt32(EnterUserIDToSearch.Text) == user.userID)
                {
                    dummy = user;
                    userFound = true;
                }
            }
            if (!userFound)
                MessageBox.Show("User not found!");

            for(int i=0; i<dummy.bookIDBorrrowedList.Count; i++)
            {
                for(int j=0; j<bookList.Count; j++)
                {
                    if (dummy.bookIDBorrrowedList[i] == bookList[j].bookID)
                        ListBoxUserHistory.Items.Add(bookList[j].GetBookInfo());
                }
                
            }
        }

        private void BorrowBookButtonOnClick(object sender, EventArgs e)
        {
            bool UserFound = false;
            bool BookFound = false;
            bool BookAvailable = false;

            Users dummyUser = new Users();

            //searches for the book (if it exists and can be borrowed)
            foreach (Books book in bookList)
            {
                 if (Convert.ToInt32(book.bookID) == Convert.ToInt32(EnterBookIDBorrow.Text))
                {
                    BookFound = true;
                    if (book.bookQuantity > 0)
                    {
                        book.bookQuantity -= 1;
                        BookAvailable = true;
                    }
                    else
                        MessageBox.Show("Book cannot be borrowed!");

                }
            }

            if (!BookFound)
                MessageBox.Show("Book not found!");

            //searches for the user and adds the book id to the list in user class
            foreach (Users user in userList)
            {
                if(Convert.ToInt32(user.userID) == Convert.ToInt32(EnterUserIDBorrow.Text))
                {
                    UserFound = true;
                    dummyUser = user;
                }

            }

            if(!UserFound)
                MessageBox.Show("User not found!");

            if (UserFound && BookFound && BookAvailable)
            {
                dummyUser.bookIDBorrrowedList.Add(Convert.ToInt32(EnterBookIDBorrow.Text));
                MessageBox.Show("Book borrowed succesfully!");
            }

            EnterBookIDBorrow.Text = String.Empty;
            EnterUserIDBorrow.Text = String.Empty;
        }
    }

}
