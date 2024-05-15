namespace SCD.EntityFramework.Type2.Model;

public interface IScdType2Model<TKeyType>
{
    TKeyType ScdType2_Id { get; set; }
    DateTime ScdType2_StartDate { get; set; }
    DateTime ScdType2_EndDate { get; set; }
    bool ScdType2_Active { get; set; }
}