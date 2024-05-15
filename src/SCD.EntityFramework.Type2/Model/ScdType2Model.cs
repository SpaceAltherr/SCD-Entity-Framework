using System.ComponentModel.DataAnnotations;

namespace SCD.EntityFramework.Type2.Model;

public class ScdType2Model<TKeyType> : IScdType2Model<TKeyType>
{
    [Key]
    public TKeyType ScdType2_Id { get; set; }
    public DateTime ScdType2_StartDate { get; set; }
    public DateTime ScdType2_EndDate { get; set; }
    public bool ScdType2_Active { get; set; }
}

public class ScdType2Model : ScdType2Model<Guid>
{
    
}