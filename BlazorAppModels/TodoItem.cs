using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppModels
{
    public class TodoItem
    {
        public int id {  get; set; }
        public string Title { get; set; }

        public bool  IsDone { get; set; }

    }
}
