import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { productsColumns, productsRow, productsService } from '../../ServerTypes/onlinestore';
import { productsDialog } from './productsDialog';

@Decorators.registerClass('AdminArea.onlinestore.productsGrid')
export class productsGrid extends EntityGrid<productsRow, any> {
    protected getColumnsKey() { return productsColumns.columnsKey; }
    protected getDialogType() { return productsDialog; }
    protected getRowDefinition() { return productsRow; }
    protected getService() { return productsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}