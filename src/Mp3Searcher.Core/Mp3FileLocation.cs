using System.ComponentModel.DataAnnotations.Schema;

namespace Mp3Searcher.Core
{
    [Table("Mp3File")]
    public class Mp3FileLocation
    {
        public int Id { get; set; }

        public string Path { get; set; }
    }
}
