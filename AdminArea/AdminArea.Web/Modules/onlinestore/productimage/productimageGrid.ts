import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { productimageColumns, productimageRow, productimageService } from '../../ServerTypes/onlinestore';
import { productimageDialog } from './productimageDialog';

@Decorators.registerClass('AdminArea.onlinestore.productimageGrid')
export class productimageGrid extends EntityGrid<productimageRow, any> {
    protected getColumnsKey() { return productimageColumns.columnsKey; }
    protected getDialogType() { return productimageDialog; }
    protected getRowDefinition() { return productimageRow; }
    protected getService() { return productimageService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}