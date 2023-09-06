import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { cartColumns, cartRow, cartService } from '../../ServerTypes/onlinestore';
import { cartDialog } from './cartDialog';

@Decorators.registerClass('AdminArea.onlinestore.cartGrid')
export class cartGrid extends EntityGrid<cartRow, any> {
    protected getColumnsKey() { return cartColumns.columnsKey; }
    protected getDialogType() { return cartDialog; }
    protected getRowDefinition() { return cartRow; }
    protected getService() { return cartService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}