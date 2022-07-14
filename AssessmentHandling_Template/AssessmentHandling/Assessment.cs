using System;
using System.Collections.Generic;
using System.Text;

namespace AssessmentHandling
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public string AssessmentType { get; set; }
        public DateTime AssessmentDate { get; set; }
        public string track { get; set; }

        public Assessment(int id, string name, string type, DateTime assessmentDate, string track)
        {
            this.AssessmentId = id;
            this.AssessmentName = name;
            this.AssessmentType = type;
            this.AssessmentDate = assessmentDate;
            this.track = track;
        }

        public Assessment()
        {
        }
    }
}
