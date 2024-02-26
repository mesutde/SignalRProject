using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SignalRWebUI.Dtos.MenuTableDtos
{
    public class ResultMenuTableDto
    {
        public int MenuTableID { get; set; }
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}