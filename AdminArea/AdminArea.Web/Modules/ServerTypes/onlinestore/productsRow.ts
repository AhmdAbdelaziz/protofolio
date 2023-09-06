import { fieldsProxy } from "@serenity-is/corelib/q";

export interface productsRow {
    Id?: number;
    Name?: string;
    Price?: number;
    Description?: string;
    Code?: number;
    CategoryId?: number;
    Photo?: string;
    SupplierName?: string;
    EntryDate?: string;
    ReviewUrl?: string;
    Quantity?: number;
    CategoryName?: string;
}

export abstract class productsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'onlinestore.products';
    static readonly deletePermission = 'products';
    static readonly insertPermission = 'products';
    static readonly readPermission = 'products';
    static readonly updatePermission = 'products';

    static readonly Fields = fieldsProxy<productsRow>();
}