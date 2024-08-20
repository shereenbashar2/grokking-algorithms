using System.ComponentModel;

namespace AlgorithmsApi.Models;

public class BinarySearchSearchRequest
{
    [DefaultValue(new int[] { 1, 3, 5, 7, 9 })]
    public int[] Array { get; set; }

    [DefaultValue(3)]
    public int Target { get; set; }
}
