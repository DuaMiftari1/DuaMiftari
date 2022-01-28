using System.ComponentModel.DataAnnotations;

namespace WebResume.Models {    
    public class Information
    {
        [Key] public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AboutMe { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
        public string Hobbies { get; set; }

        public Information(){}       
    }
}
