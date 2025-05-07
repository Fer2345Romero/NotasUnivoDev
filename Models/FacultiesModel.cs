using System.ComponentModel.DataAnnotations;

namespace NotasUnivoDev.Models
{
    public class FacultiesModel: BaseModel
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public List<CareersModel> Careers { get; set; }

        //datos quemado
        public FacultiesModel()
        {
            IsActive = true;
            Created = DateTime.Now;
            CreatedBy = "ADMIN";
        }
    }
}
