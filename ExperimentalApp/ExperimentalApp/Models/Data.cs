using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentalApp.Models
{
    public class Data
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int max { get; set; }
        public int min { get; set; }
    }
}
