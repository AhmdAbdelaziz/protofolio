import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface categoryRow {
    Id?: number;
    Name?: string;
    Photo?: string;
    Description?: string;
}

export abstract class categoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'onlinestore.category';
    static readonly lookupKey = 'onlinestore.category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<categoryRow>('onlinestore.category') }
    static async getLookupAsync() { return getLookupAsync<categoryRow>('onlinestore.category') }

    static readonly deletePermission = 'category';
    static readonly insertPermission = 'category';
    static readonly readPermission = 'category';
    static readonly updatePermission = 'category';

    static readonly Fields = fieldsProxy<categoryRow>();
}