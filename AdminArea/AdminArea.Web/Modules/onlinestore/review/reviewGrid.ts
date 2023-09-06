import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { reviewColumns, reviewRow, reviewService } from '../../ServerTypes/onlinestore';
import { reviewDialog } from './reviewDialog';

@Decorators.registerClass('AdminArea.onlinestore.reviewGrid')
export class reviewGrid extends EntityGrid<reviewRow, any> {
    protected getColumnsKey() { return reviewColumns.columnsKey; }
    protected getDialogType() { return reviewDialog; }
    protected getRowDefinition() { return reviewRow; }
    protected getService() { return reviewService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}