using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class ToDoTaskLabel
    {
        public Guid TaskId { get; set; }
        public ToDoTask Task { get; set; }

        public Guid TaskLabelId { get; set; }
        public TaskLabel TaskLabel { get; set; }
    }
}
