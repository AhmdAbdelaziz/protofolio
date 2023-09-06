import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { reviewForm, reviewRow, reviewService } from '../../ServerTypes/onlinestore';

@Decorators.registerClass('AdminArea.onlinestore.reviewDialog')
export class reviewDialog extends EntityDialog<reviewRow, any> {
    protected getFormKey() { return reviewForm.formKey; }
    protected getRowDefinition() { return reviewRow; }
    protected getService() { return reviewService.baseUrl; }

    protected form = new reviewForm(this.idPrefix);
}