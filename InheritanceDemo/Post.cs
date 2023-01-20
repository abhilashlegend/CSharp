using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Post : Object
    {
        private static int currentPostId;

        // Class Properties

        public int ID { get; set; }

        public string Title { get; set; }

        public bool IsPublic { get; set; }

        public string SendByUsername { get; set; }

        /* Default Constructor: If a derived class does not invoke a base class constructor explicitly,
         * the default constructor is called implicitly */
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Abhilash N";
        }

        /* Instance Constructor that has 3 parameters */
        public Post(string title, bool ispublic, string sendByUsername)
        {
            this.ID = getNextID();
            this.Title = title;
            this.IsPublic = ispublic;
            this.SendByUsername = sendByUsername;
        }

        protected int getNextID()
        {
            return ++currentPostId;
        }

        public void update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        /* Virtual method override of the ToString method that is inherited from System.Object */
        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }


    }
}
