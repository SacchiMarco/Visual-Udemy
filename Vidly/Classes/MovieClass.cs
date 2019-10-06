using Microsoft.Ajax.Utilities;

namespace Vidly.Classes 
{
    public class MovieClass
    {
        public MovieClass(string name)
        {
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}