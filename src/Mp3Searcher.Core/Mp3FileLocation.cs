using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mp3Searcher.Core
{
    [Table("Mp3FileLocation")]
    public class Mp3FileLocation
    {
        public int Id { get; set; }

        public string Path { get; set; }
    }
}
