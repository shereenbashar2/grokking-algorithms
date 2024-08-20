using AlgorithmsApi.Algorithms;
using AlgorithmsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmsApi.Controllers;

public class AlgorithmsController : ControllerBase
{
    private readonly BinarySearch _binarySearch;

    public AlgorithmsController()
    {
        _binarySearch = new BinarySearch();
    }

    [HttpPost("binary-search")]
    public ActionResult<int> BinarySearch([FromBody] BinarySearchSearchRequest request)
    {
        var index = _binarySearch.Execute(request.Array, request.Target);
        if (index != -1)
        {
            return Ok(index);
        }
        return NotFound("Target not found in the array.");
    }
}
