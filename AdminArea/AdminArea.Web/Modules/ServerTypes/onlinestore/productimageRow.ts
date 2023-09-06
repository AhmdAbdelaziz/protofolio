import { fieldsProxy } from "@serenity-is/corelib/q";

export interface productimageRow {
    Id?: number;
    ProductId?: number;
    Image?: string;
    ProductName?: string;
}

export abstract class productimageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Image';
    static readonly localTextPrefix = 'onlinestore.productimage';
    static readonly deletePermission = 'productimage';
    static readonly insertPermission = 'productimage';
    static readonly readPermission = 'productimage';
    static readonly updatePermission = 'productimage';

    static readonly Fields = fieldsProxy<productimageRow>();
}