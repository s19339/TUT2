


using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tut2.Models
{
    public class Student
    {

        [JsonPropertyName("indexNumber")]
        [XmlAttribute(AttributeName = "indexNumber")]
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public string EmailId { get; set; }

        public string MotherName { get; set; }

        public string FatherName { get; set; }

        public Studies studies { get; set; }


    }
}