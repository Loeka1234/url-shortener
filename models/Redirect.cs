using System;

namespace URLShortener.Controllers
{
  public class Redirect
  {
    public int Id { get; set; }
    private string destination;
    private string path;
    public string Path
    {
      get { return path; }
      set
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentNullException();

        path = value;
      }
    }
    public string Destination
    {
      get { return destination; }
      set
      {
        if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
          throw new ArgumentException("value must be a valid URI");
        destination = value;
      }
    }
  }
}