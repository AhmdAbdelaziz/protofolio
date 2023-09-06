import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { productimageForm, productimageRow, productimageService } from '../../ServerTypes/onlinestore';

@Decorators.registerClass('AdminArea.onlinestore.productimageDialog')
export class productimageDialog extends EntityDialog<productimageRow, any> {
    protected getFormKey() { return productimageForm.formKey; }
    protected getRowDefinition() { return productimageRow; }
    protected getService() { return productimageService.baseUrl; }

    protected form = new productimageForm(this.idPrefix);
}