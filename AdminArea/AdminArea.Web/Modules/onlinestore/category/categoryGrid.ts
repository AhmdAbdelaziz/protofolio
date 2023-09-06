import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { categoryColumns, categoryRow, categoryService } from '../../ServerTypes/onlinestore';
import { categoryDialog } from './categoryDialog';

@Decorators.registerClass('AdminArea.onlinestore.categoryGrid')
export class categoryGrid extends EntityGrid<categoryRow, any> {
    protected getColumnsKey() { return categoryColumns.columnsKey; }
    protected getDialogType() { return categoryDialog; }
    protected getRowDefinition() { return categoryRow; }
    protected getService() { return categoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}