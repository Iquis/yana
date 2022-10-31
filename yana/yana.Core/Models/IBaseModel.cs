using yana.Core.Dto;

namespace yana.Core.Models;

public interface IBaseModel<out T> where T : IDto
{
    T ToDto();
}