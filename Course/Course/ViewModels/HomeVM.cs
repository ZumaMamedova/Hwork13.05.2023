using Course.Models;
using System.Collections.Generic;

namespace Course.ViewModels
{
    public class HomeVM
    {
        public List<Student>Students { get; set; }
        public List<Group>Groups { get; set; }
    }
}
