using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XML_H3SCHOOL_MVC.Models
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class school
    {

        private List<schoolTeam> teamsField;

        private List<schoolClassroom> classroomsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("team", IsNullable = false)]
        public List<schoolTeam> teams
        {
            get
            {
                return this.teamsField;
            }
            set
            {
                this.teamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("classroom", IsNullable = false)]
        public List<schoolClassroom> classrooms
        {
            get
            {
                return this.classroomsField;
            }
            set
            {
                this.classroomsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class schoolTeam
    {

        private List<schoolTeamStudent> studentsField;

        private List<schoolTeamSubject> subjectsField;

        private string idField;

        private string classroomidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("student", IsNullable = false)]
        public List<schoolTeamStudent> students
        {
            get
            {
                return this.studentsField;
            }
            set
            {
                this.studentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("subject", IsNullable = false)]
        public List<schoolTeamSubject> subjects
        {
            get
            {
                return this.subjectsField;
            }
            set
            {
                this.subjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classroomid
        {
            get
            {
                return this.classroomidField;
            }
            set
            {
                this.classroomidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class schoolTeamStudent
    {

        private string firstnameField;

        private string lastnameField;

        private byte ageField;

        private uint idField;

        /// <remarks/>
        public string firstname
        {
            get
            {
                return this.firstnameField;
            }
            set
            {
                this.firstnameField = value;
            }
        }

        /// <remarks/>
        public string lastname
        {
            get
            {
                return this.lastnameField;
            }
            set
            {
                this.lastnameField = value;
            }
        }

        /// <remarks/>
        public byte age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class schoolTeamSubject
    {

        private string nameField;

        private string idField;

        private string suidField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string suid
        {
            get
            {
                return this.suidField;
            }
            set
            {
                this.suidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class schoolClassroom
    {

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}

