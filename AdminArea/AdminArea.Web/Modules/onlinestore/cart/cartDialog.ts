import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { cartForm, cartRow, cartService } from '../../ServerTypes/onlinestore';

@Decorators.registerClass('AdminArea.onlinestore.cartDialog')
export class cartDialog extends EntityDialog<cartRow, any> {
    protected getFormKey() { return cartForm.formKey; }
    protected getRowDefinition() { return cartRow; }
    protected getService() { return cartService.baseUrl; }

    protected form = new cartForm(this.idPrefix);
}