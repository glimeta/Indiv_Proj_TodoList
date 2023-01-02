using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Indiv_Proj_TodoList
{
    public class TaskItem
    {

        private string _description;
        private string _isCompleted;
        private int _itemID;


        public string Description { get => _description; set => _description = value; }
        public string IsCompleted { get => _isCompleted; set => _isCompleted = value; }
        public int ItemID { get => _itemID; set => _itemID = value; }



        public TaskItem()
        {

        }
        public TaskItem(string isCompleted, string description, int itemID)
        {
            this.ItemID = itemID;
            this.Description = description;
            this.IsCompleted = isCompleted;

        }

        
        public virtual void DisplayList()
        {            
            Console.WriteLine(this.IsCompleted.PadRight(18) + this.Description.PadRight(25) + this.ItemID);

        }

    }
}
