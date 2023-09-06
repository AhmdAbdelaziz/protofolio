import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { productsForm, productsRow, productsService } from '../../ServerTypes/onlinestore';

@Decorators.registerClass('AdminArea.onlinestore.productsDialog')
export class productsDialog extends EntityDialog<productsRow, any> {
    protected getFormKey() { return productsForm.formKey; }
    protected getRowDefinition() { return productsRow; }
    protected getService() { return productsService.baseUrl; }

    protected form = new productsForm(this.idPrefix);
}