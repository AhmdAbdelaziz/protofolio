import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { diagramColumns, diagramRow, diagramService } from '../../ServerTypes/onlinestore';
import { diagramDialog } from './diagramDialog';

@Decorators.registerClass('AdminArea.onlinestore.diagramGrid')
export class diagramGrid extends EntityGrid<diagramRow, any> {
    protected getColumnsKey() { return diagramColumns.columnsKey; }
    protected getDialogType() { return diagramDialog; }
    protected getRowDefinition() { return diagramRow; }
    protected getService() { return diagramService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}