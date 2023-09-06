import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { categoryForm, categoryRow, categoryService } from '../../ServerTypes/onlinestore';

@Decorators.registerClass('AdminArea.onlinestore.categoryDialog')
export class categoryDialog extends EntityDialog<categoryRow, any> {
    protected getFormKey() { return categoryForm.formKey; }
    protected getRowDefinition() { return categoryRow; }
    protected getService() { return categoryService.baseUrl; }

    protected form = new categoryForm(this.idPrefix);
}