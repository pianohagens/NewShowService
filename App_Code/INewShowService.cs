using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INewShowService" in both code and config file together.
[ServiceContract]
public interface INewShowService
{
    [OperationContract]
    List<Show> GetShowsByArtist(string artistName);
     
}
 [DataContract]
public class ShowInfo
{
    [DataMember]
    public string ArtistName { get; set; }
    [DataMember]
    public string ShowName { get; set; }
    [DataMember]
    public string ShowDate { get; set; }
    [DataMember]
    public string ShowTime { get; set; }

    [DataMember]
    public string TicketInfo { get; set; }
}