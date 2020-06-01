using System;

namespace n9799532_cab301
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        //go to either staff or member menu depend on user, which will start its own loop
        static void MainMenu()
        {
            while (true)
            {
                int userChoice;

                do
                {

                    Console.WriteLine("Welcome to the Community Library");
                    Console.WriteLine("===========Main Menu===========");
                    Console.WriteLine("1. Staff login");
                    Console.WriteLine("2. Member login");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("===============================");
                    Console.WriteLine("");
                    Console.WriteLine("Please make a selection (1-2, or 0 to exit \n");

                } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > 2);

                switch (userChoice)
                {
                    case 1:
                        StaffCheck();
                        break;

                    case 2:
                        MemberCheck();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter 1, 2, or 0! ");
                        break;

                }

            }
        }

        // Check staff username and password
        static void StaffCheck()
        {
            string username;
            string password;
            do
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
            } while (username != "staff" || password != "today123");

            StaffMenu();

        }

        // Check member username and password
        static void MemberCheck()
        {
            string username;
            string password;
            do
            {
                Console.WriteLine("Enter your username: (LastnameFirstname)");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
            } while (username != "LoKawai" || password != "1111");

            MemberMenu();

        }

        //got differnt function to choose on member menu depend on user
        static void MemberMenu()
        {
            while (true)
            {
                int dvdChoice;

                do
                {

                    Console.WriteLine("===========Member Menu===========");
                    Console.WriteLine("1. Display all movies");
                    Console.WriteLine("2. Borrow a movie DVD");
                    Console.WriteLine("3. Return a movie DVD");
                    Console.WriteLine("4. List current borrowed movie DVDs");
                    Console.WriteLine("5. Display top 10 most popular movies");
                    Console.WriteLine("0. Return to main menu");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Please make a selection (1-5, or 0 to return main menu \n");

                } while (!int.TryParse(Console.ReadLine(), out dvdChoice) || dvdChoice < 0 || dvdChoice > 5);


                switch (dvdChoice)
                {
                    case 1:
                        AllMovie();
                        break;

                    case 2:
                        Borrow();
                        break;

                    case 3:
                        Return();
                        break;

                    case 4:
                        Rented();
                        break;

                    case 5:
                        Top();
                        break;

                    case 0:
                        MainMenu();
                        break;
                }


            }

        }

        //got differnt function to choose on staff menu depend on user

        static void StaffMenu()
        {
            while (true)
            {
                int optChoice;

                do
                {

                    Console.WriteLine("\n===========Staff Menu===========");
                    Console.WriteLine("1. Add a new movie DVD");
                    Console.WriteLine("2. Remove a movie DVD");
                    Console.WriteLine("3. Register a new Member");
                    Console.WriteLine("4. Find a registered member's phone number");
                    Console.WriteLine("0. Return to main menu");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Please make a selection (1 - 4, or 0 to return main menu) ");

                } while (!int.TryParse(Console.ReadLine(), out optChoice) || optChoice < 0 || optChoice > 4);


                switch (optChoice)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Remove();
                        break;

                    case 3:
                        NewMember();
                        break;

                    case 4:
                        FindNumber();
                        break;


                    case 0:
                        MainMenu();
                        break;
                }


            }

        }

        // Show all movie
        static void AllMovie()
        {

            Console.WriteLine("\nTitle:");
            Console.WriteLine("Starring: ");
            Console.WriteLine("Director: ");
            Console.WriteLine("Genre");
            Console.WriteLine("Classification");
            Console.WriteLine("Duration (minutes): ");
            Console.WriteLine("Realese date (year): ");
            Console.WriteLine("Copies available: ");
            Console.WriteLine("Times Rented: ");

        }

        // Remove movie
        static void Remove()
        {
            Console.WriteLine("\nEnter the movie title: ");
            String title = Console.ReadLine();

            Console.WriteLine(title + " was deleted");
        }

        // Borrow movie
        static void Borrow()
        {
            Console.WriteLine("\nEnter the movie title: ");
            String title = Console.ReadLine();

            Console.WriteLine("You borrowed " + title);
        }

        // Return movie
        static void Return()
        {
            Console.WriteLine("\nEnter the movie title: ");
            String title = Console.ReadLine();

            Console.WriteLine(title + " returned");
        }

        // Rented movie
        static void Rented()
        {
            Console.WriteLine("You are currently borrowing: ");
            Console.WriteLine("Movie 2");
        }

        // Top list of the movie
        static void Top()
        {
            Console.WriteLine("Movie 3 borrowed 3 times ");
            Console.WriteLine("Movie 2 borrowed 1 times ");
            Console.WriteLine("Movie 5 borrowed 2 times ");

        }

        // Add movie 
        static void Add()
        {

            Console.WriteLine("\nEnter the movie title: ");
            String title = Console.ReadLine();
            Console.WriteLine("Enter the staring actor(s): ");
            String actor = Console.ReadLine();
            Console.WriteLine("Enter the director(s): ");
            String director = Console.ReadLine();

            Console.WriteLine("\nSelect the genre");
            Console.WriteLine("1. Drama");
            Console.WriteLine("2. Adventure");
            Console.WriteLine("3. Family");
            Console.WriteLine("4. Action");
            Console.WriteLine("5. Sci-Fi");
            Console.WriteLine("6. Comedy");
            Console.WriteLine("7. Thriller");
            Console.WriteLine("8. Other");
            Console.WriteLine("Make  selection (1-8)");
            String genre = Console.ReadLine();

            Console.WriteLine("\nSelect the classification");
            Console.WriteLine("1. General (G)");
            Console.WriteLine("2. Parental Guidance (PG)");
            Console.WriteLine("3. Mature (M15+)");
            Console.WriteLine("4. Mature Accompanied (MA15+)");
            Console.WriteLine("Make  selection (1-4)");
            String classification = Console.ReadLine();


            Console.WriteLine("Enter the duration (minutes): ");
            String duration = Console.ReadLine();
            Console.WriteLine("Enter the realese date (year): ");
            String date = Console.ReadLine();
            Console.WriteLine("Enter the number of copies available: ");
            String copies = Console.ReadLine();

        }



        //  object of the class Movie
        public class Movie
        {
            public string title;
            public string starring;
            public string director;
            public int duration;
            public string genre;
            public string classification;
            public string releaseDate;

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Starring
            {
                get { return starring; }
                set { starring = value; }
            }

            public string Director
            {
                get { return Director; }
                set { Director = value; }
            }

            public int Duration
            {
                get { return duration; }
                set { duration = value; }
            }

            public int ReleaseDate
            {
                get { return ReleaseDate; }
                set { ReleaseDate = value; }
            }


            public enum Genre
            {
                Drama,
                Adventure,
                Family,
                Action,
                SciFi,
                Comedy,
                Animated,
                Thriller,
                Other
            }

            public enum classified
            {
                General,
                ParentalGuidance,
                Mature,
                MatureAccompanied

            }

        }

        // Store value using Binary search tree
        public class MovieCollection
        {
            public class Node
            {
                public Node Left { get; set; }
                public Node Right { get; set; }
                public Node Root { get; set; }
                public int Data { get; set; }

            }

            public Node root { get; set; }

            public MovieCollection()
            {
                root = null;
            }

            public Node ReturnRoot()
            {
                return root;
            }

            public bool Add(int value)
            {
                Node before = null, after = this.root;

                while (after != null)
                {
                    before = after;
                    if (value < after.Data) //Is new node in left tree? 
                        after = after.Left;
                    else if (value > after.Data) //Is new node in right tree?
                        after = after.Right;
                    else
                    {
                        //Exist same value
                        return false;
                    }
                }

                Node newNode = new Node();
                newNode.Data = value;

                if (this.root == null)//Tree ise empty
                    this.root = newNode;
                else
                {
                    if (value < before.Data)
                        before.Left = newNode;
                    else
                        before.Right = newNode;
                }

                return true;
            }

            public void Remove(int value)
            {
                this.root = Remove(this.root, value);
            }

            private Node Remove(Node parent, int key)
            {
                if (parent == null) return parent;

                if (key < parent.Data) parent.Left = Remove(parent.Left, key);
                else if (key > parent.Data)
                    parent.Right = Remove(parent.Right, key);

                // if value is same as parent's value, then this is the node to be deleted  
                else
                {
                    // node with only one child or no child  
                    if (parent.Left == null)
                        return parent.Right;
                    else if (parent.Right == null)
                        return parent.Left;

                    // node with two children: Get the inorder successor (smallest in the right subtree)  
                    parent.Data = MinValue(parent.Right);

                    // Delete the inorder successor  
                    parent.Right = Remove(parent.Right, parent.Data);
                }

                return parent;
            }

            private int MinValue(Node node)
            {
                int minv = node.Data;

                while (node.Left != null)
                {
                    minv = node.Left.Data;
                    node = node.Left;
                }

                return minv;
            }

            private Node Find(int value, Node parent)
            {
                if (parent != null)
                {
                    if (value == parent.Data) return parent;
                    if (value < parent.Data)
                        return Find(value, parent.Left);
                    else
                        return Find(value, parent.Right);
                }

                return null;
            }

            public int GetTreeDepth()
            {
                return this.GetTreeDepth(this.root);
            }

            private int GetTreeDepth(Node parent)
            {
                return parent == null ? 0 : Math.Max(GetTreeDepth(parent.Left), GetTreeDepth(parent.Right)) + 1;
            }

            public void TraversePreOrder(Node parent)
            {
                if (parent != null)
                {
                    Console.Write(parent.Data + " ");
                    TraversePreOrder(parent.Left);
                    TraversePreOrder(parent.Right);
                }
            }

            public void TraverseInOrder(Node parent)
            {
                if (parent != null)
                {
                    TraverseInOrder(parent.Left);
                    Console.Write(parent.Data + " ");
                    TraverseInOrder(parent.Right);
                }
            }

            public void TraversePostOrder(Node parent)
            {
                if (parent != null)
                {
                    TraversePostOrder(parent.Left);
                    TraversePostOrder(parent.Right);
                    Console.Write(parent.Data + " ");
                }
            }







        }

        //object of the class Member
        public class Member
        {
            private string firstname;
            private string lastname;
            private string address;
            private int phone;
            private int password;

            public string FirstName
            {
                get { return firstname; }
                set { firstname = value; }
            }

            public string LastName
            {
                get { return lastname; }
                set { lastname = value; }
            }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            public int Phone
            {
                get { return phone; }
                set { phone = value; }
            }
            public int Password
            {
                get { return password; }
                set { password = value; }
            }

            /*
            public Member( string firstname, string lastname, string address, int phone, int password) 
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.address = address;
                this.phone = phone;
                this.password = password;
            }
            */


            public Member()
            {
                firstname = null;
                lastname = null;
                address = null;
                phone = 0;
                password = 0;
            }

            public override string ToString()
            {
                string text = null;
                text += "First Name: " + FirstName;
                text += "irst Name: " + LastName;
                text += "First Name: " + Address;
                text += "First Name: " + Phone;
                text += "First Name: " + Password;

                return text;

            }


        }


        // Store value using Array

        public class MemberCollection
        {
            Member[] memberArray = new Member[10];

        }

        // Create new member
        static void NewMember()
        {

            int i = 1;
            Member[] memberArray = new Member[i];

            for (int k = 0; k < memberArray.Length; k++)
            {
                memberArray[k] = new Member();

                Console.WriteLine("\nEnter member's first name: ");
                memberArray[k].FirstName = Console.ReadLine();

                Console.WriteLine("Enter member's last name: ");
                memberArray[k].LastName = Console.ReadLine();

                if (memberArray[k].FirstName == "Kawai" && memberArray[k].LastName == "Loo")
                {
                    Console.WriteLine(memberArray[k].FirstName + memberArray[k].LastName + " has already registered\n");

                }

                else
                {
                    Console.WriteLine("Enter member's Address: ");
                    memberArray[k].Address = Console.ReadLine();

                    Console.WriteLine("Enter member's Phone number: ");
                    memberArray[k].Phone = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter member's password (4-digit): ");
                    memberArray[k].Password = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Successfully added" + memberArray[k].FirstName + memberArray[k].LastName);

                }

            }

        }

        // Find member's number with their name

        static void FindNumber()
        {
            /*
            int i = 0;
            Member[] memberArray = new Member[i];

            Array.Sort(memberArray );

            Console.WriteLine("Enter member's first name: ");
            memberArray[i].FirstName = Console.ReadLine();

            Console.WriteLine("Enter member's last name: ");
            memberArray[i].LastName = Console.ReadLine();

            Member search = new Member { FirstName = memberArray[i].FirstName, LastName = memberArray[i].LastName };
            */

            int i = 1;
            Member[] memberArray = new Member[i];

            for (int k = 0; k < memberArray.Length; k++)
            {
                memberArray[k] = new Member();

                Console.WriteLine("\nEnter member's first name: ");
                memberArray[k].FirstName = Console.ReadLine();

                Console.WriteLine("Enter member's last name: ");
                memberArray[k].LastName = Console.ReadLine();

                if (memberArray[k].FirstName == "Kawai" && memberArray[k].LastName == "Lo")
                {
                    Console.WriteLine(memberArray[k].FirstName + "" + memberArray[k].LastName + "'s phone number is:" + memberArray[k].Phone);

                }

                else
                {
                    Console.WriteLine("incorrect username ");

                }

            }

        }


    }




}

