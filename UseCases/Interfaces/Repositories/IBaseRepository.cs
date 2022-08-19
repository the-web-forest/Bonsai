namespace Bonsai.UseCases.Interfaces.Repositories
{
	public interface IBaseRepository<in T>
	{
		Task Create(T Data);
		Task Update(T Data);
	}
}

