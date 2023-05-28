﻿using ProductOfferGrpcService.Entities;

namespace ProductOfferGrpcService.Repositories
{
    public interface IProductOfferService
    {
        public Task<List<Offer>> GetOfferListAsync();
        public Task<Offer> GetOfferByIdAsync(int Id);
        public Task<Offer> AddOfferAsync(Offer offer);
        public Task<Offer> UpdateOfferAsync(Offer offer);
        public Task<bool> DeleteOfferAsync(int Id);
    }
}
