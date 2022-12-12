namespace GiftingApi.Domain
{
    public interface ICatalogPeople
    {
        public Task<PersonResponse> GetPeopleAsync();
    }
}