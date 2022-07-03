using System;
namespace zaliczenie
{
    public abstract class Item
    {
        public string id;
        public string groupId;

        public Item()
        {
            this.id = this.GenerateId();
            this.groupId = this.GenerateId();
        }

        //helper function for generating random ID
        public string GenerateId()
        {
            long ticks = DateTime.Now.Ticks;
            string guid = Guid.NewGuid().ToString();
            string uniqueSessionId = ticks.ToString() + '-' + guid;

            return uniqueSessionId;
        }
    }
}

