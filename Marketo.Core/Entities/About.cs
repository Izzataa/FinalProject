using System.ComponentModel.DataAnnotations.Schema;

namespace Marketo.Core.Entities;

public class About: BaseEntity
{
    public string Image { get; set; }
    public string SubTitle { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public byte Order { get; set; }
  
    
}
