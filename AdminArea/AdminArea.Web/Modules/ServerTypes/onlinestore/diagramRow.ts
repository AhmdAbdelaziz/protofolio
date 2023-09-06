import { fieldsProxy } from "@serenity-is/corelib/q";

export interface diagramRow {
    Name?: string;
    PrincipalId?: number;
    DiagramId?: number;
    Version?: number;
    Definition?: number[];
}

export abstract class diagramRow {
    static readonly idProperty = 'DiagramId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'onlinestore.diagram';
    static readonly deletePermission = 'diagram';
    static readonly insertPermission = 'diagram';
    static readonly readPermission = 'diagram';
    static readonly updatePermission = 'diagram';

    static readonly Fields = fieldsProxy<diagramRow>();
}