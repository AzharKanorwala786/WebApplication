using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int QType { get; set; }

        public string QuestionType { get; set; }

        public IEnumerable<QuestionPickList> QuestionPickList { get; set; }
    }
}