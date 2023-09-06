import { fieldsProxy } from "@serenity-is/corelib/q";

export interface reviewRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Subject?: string;
    Email?: string;
}

export abstract class reviewRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'onlinestore.review';
    static readonly deletePermission = 'review';
    static readonly insertPermission = 'review';
    static readonly readPermission = 'review';
    static readonly updatePermission = 'review';

    static readonly Fields = fieldsProxy<reviewRow>();
}