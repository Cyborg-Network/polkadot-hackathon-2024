//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> mint
        /// Issue a new avatar.
        /// 
        /// Emits `AvatarsMinted` event when successful.
        /// 
        /// Weight: `O(n)` where:
        /// - `n = max avatars per player`
        /// </summary>
        mint = 0,
        
        /// <summary>
        /// >> forge
        /// Forge an avatar.
        /// 
        /// This action can enhance the skills of an avatar by consuming a batch of avatars.
        /// The minimum and maximum number of avatars that can be utilized for forging is
        /// defined in the season configuration.
        /// 
        /// Emits `AvatarForged` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        forge = 1,
        
        /// <summary>
        /// >> transfer_avatar
        /// </summary>
        transfer_avatar = 2,
        
        /// <summary>
        /// >> transfer_free_mints
        /// Transfer free mints to a given account.
        /// 
        /// Emits `FreeMintsTransferred` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        transfer_free_mints = 3,
        
        /// <summary>
        /// >> set_price
        /// Set the price of a given avatar.
        /// 
        /// Only allowed while trade period is open.
        /// 
        /// Emits `AvatarPriceSet` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_price = 4,
        
        /// <summary>
        /// >> remove_price
        /// Remove the price of a given avatar.
        /// 
        /// Only allowed while trade period is open.
        /// 
        /// Emits `AvatarPriceUnset` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        remove_price = 5,
        
        /// <summary>
        /// >> buy
        /// Buy the given avatar.
        /// 
        /// It consumes tokens for the trade operation. The avatar will be owned by the
        /// player after the transaction.
        /// 
        /// Only allowed while trade period is open.
        /// 
        /// Emits `AvatarTraded` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        buy = 6,
        
        /// <summary>
        /// >> upgrade_storage
        /// Upgrade the avatar inventory space in a season.
        /// 
        /// * If called with a value in the **beneficiary** parameter, that account will receive the
        ///   upgrade
        /// instead of the caller.
        /// * If the **in_season** parameter contains a value, this will set which specific season
        /// will the storage be upgraded for, if no value is set then the current season will be the
        /// one for which the storage will be upgraded.
        /// 
        /// In all cases the upgrade fees are **paid by the caller**.
        /// 
        /// Emits `StorageTierUpgraded` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        upgrade_storage = 7,
        
        /// <summary>
        /// >> set_organizer
        /// Set game organizer.
        /// 
        /// The organizer account is like an admin, allowed to perform certain operations
        /// related with the game configuration like `set_season`, `ensure_free_mint` and
        /// `update_global_config`.
        /// 
        /// It can only be set by a root account.
        /// 
        /// Emits `OrganizerSet` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_organizer = 8,
        
        /// <summary>
        /// >> set_treasurer
        /// Set treasurer.
        /// 
        /// This is an additional treasury.
        /// 
        /// It can only be set by a root account.
        /// 
        /// Emits `TreasurerSet` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_treasurer = 9,
        
        /// <summary>
        /// >> claim_treasury
        /// Claim treasury of a season.
        /// 
        /// The origin of this call must be signed by a treasurer account associated with the given
        /// season ID. The treasurer of a season can claim the season's associated treasury once the
        /// season finishes.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        claim_treasury = 10,
        
        /// <summary>
        /// >> set_season
        /// Set season.
        /// 
        /// Creates a new season. The new season can overlap with the already existing.
        /// 
        /// It can only be set by an organizer account.
        /// 
        /// Emits `UpdatedSeason` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_season = 11,
        
        /// <summary>
        /// >> update_global_config
        /// Update global configuration.
        /// 
        /// It can only be called by an organizer account.
        /// 
        /// Emits `UpdatedGlobalConfig` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        update_global_config = 12,
        
        /// <summary>
        /// >> set_free_mints
        /// Set free mints.
        /// 
        /// It can only be called by an organizer account.
        /// 
        /// Emits `FreeMintSet` event when successful.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_free_mints = 13,
        
        /// <summary>
        /// >> set_collection_id
        /// Set the collection ID to associate avatars with.
        /// 
        /// Externally created collection ID for avatars must be set in the `CollectionId` storage
        /// to serve as a lookup for locking and unlocking avatars as NFTs.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_collection_id = 14,
        
        /// <summary>
        /// >> lock_avatar
        /// Locks an avatar to be tokenized as an NFT.
        /// 
        /// The origin of this call must specify an avatar, owned by the origin, to prevent it from
        /// forging, trading and transferring it to other players. When successful, the ownership of
        /// the avatar is removed from the player.
        /// 
        /// Locking an avatar allows for new
        /// ways of interacting with it currently under development.
        /// 
        /// Weight: `O(n)` where:
        /// - `n = max avatars per player`
        /// </summary>
        lock_avatar = 15,
        
        /// <summary>
        /// >> unlock_avatar
        /// Unlocks an avatar removing its NFT representation.
        /// 
        /// The origin of this call must specify an avatar, owned and locked by the origin, to allow
        /// forging, trading and transferring it to other players. When successful, the ownership of
        /// the avatar is transferred from the pallet's technical account back to the player and its
        /// existing NFT representation is destroyed.
        /// 
        /// Weight: `O(n)` where:
        /// - `n = max avatars per player`
        /// </summary>
        unlock_avatar = 16,
        
        /// <summary>
        /// >> set_service_account
        /// Set a service account.
        /// 
        /// The origin of this call must be root. A service account has sufficient privilege to call
        /// the `prepare_ipfs` extrinsic.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        set_service_account = 17,
        
        /// <summary>
        /// >> prepare_avatar
        /// Prepare an avatar to be uploaded to IPFS.
        /// 
        /// The origin of this call must specify an avatar, owned by the origin, to display the
        /// intention of uploading it to an IPFS storage. When successful, the `PreparedAvatar`
        /// event is emitted to be picked up by our external service that interacts with the IPFS.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        prepare_avatar = 18,
        
        /// <summary>
        /// >> unprepare_avatar
        /// Unprepare an avatar to be detached from IPFS.
        /// 
        /// The origin of this call must specify an avatar, owned by the origin, that is undergoing
        /// the IPFS upload process.
        /// 
        /// Weight: `O(1)`
        /// </summary>
        unprepare_avatar = 19,
        
        /// <summary>
        /// >> prepare_ipfs
        /// Prepare IPFS for an avatar.
        /// 
        /// The origin of this call must be signed by the service account to upload the given avatar
        /// to an IPFS storage and stores its CID. A third-party service subscribes for the
        /// `PreparedAvatar` events which triggers preparing assets, their upload to IPFS and
        /// storing their CIDs.
        /// Weight: `O(1)`
        /// </summary>
        prepare_ipfs = 20,
        
        /// <summary>
        /// >> modify_freemint_whitelist
        /// </summary>
        modify_freemint_whitelist = 21,
        
        /// <summary>
        /// >> add_affiliation
        /// </summary>
        add_affiliation = 22,
        
        /// <summary>
        /// >> enable_affiliator
        /// </summary>
        enable_affiliator = 23,
        
        /// <summary>
        /// >> remove_affiliation
        /// </summary>
        remove_affiliation = 24,
        
        /// <summary>
        /// >> set_rule_for
        /// </summary>
        set_rule_for = 25,
        
        /// <summary>
        /// >> clear_rule_for
        /// </summary>
        clear_rule_for = 26,
        
        /// <summary>
        /// >> enable_set_avatar_price
        /// </summary>
        enable_set_avatar_price = 27,
        
        /// <summary>
        /// >> enable_avatar_transfer
        /// </summary>
        enable_avatar_transfer = 28,
        
        /// <summary>
        /// >> set_unlock_config
        /// </summary>
        set_unlock_config = 29,
        
        /// <summary>
        /// >> create_tournament
        /// </summary>
        create_tournament = 30,
        
        /// <summary>
        /// >> remove_latest_tournament
        /// </summary>
        remove_latest_tournament = 31,
        
        /// <summary>
        /// >> claim_tournament_reward_for
        /// </summary>
        claim_tournament_reward_for = 32,
        
        /// <summary>
        /// >> claim_golden_duck_for
        /// </summary>
        claim_golden_duck_for = 33,
    }
    
    /// <summary>
    /// >> 407 - Variant[pallet_ajuna_awesome_avatars.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.MintOption, BaseTuple<Bajun.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseVec<Bajun.NetApi.Generated.Model.primitive_types.H256>>, BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Bajun.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.primitive_types.H256, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U16>>, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U16, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.Season>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonMeta>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.SeasonSchedule>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.season.TradeFilters>>, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.GlobalConfig, BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U16>, Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.primitive_types.H256, BaseTuple<Bajun.NetApi.Generated.Model.primitive_types.H256, Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10>, BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.pallet.EnumWhitelistOperation>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumUnlockTarget, Substrate.NetApi.Model.Types.Primitive.U16>, Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.affiliates.EnumAffiliateMethods, Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21>, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.affiliates.EnumAffiliateMethods, BaseTuple<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumUnlockTarget, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumUnlockTarget, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.config.UnlockConfigs>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.pallet_ajuna_tournament.config.TournamentConfig, Bajun.NetApi.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.tournament.AvatarRanker>, Substrate.NetApi.Model.Types.Primitive.U16, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Bajun.NetApi.Generated.Model.primitive_types.H256>>
    {
    }
}