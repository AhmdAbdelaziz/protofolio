import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { diagramForm, diagramRow, diagramService } from '../../ServerTypes/onlinestore';

@Decorators.registerClass('AdminArea.onlinestore.diagramDialog')
export class diagramDialog extends EntityDialog<diagramRow, any> {
    protected getFormKey() { return diagramForm.formKey; }
    protected getRowDefinition() { return diagramRow; }
    protected getService() { return diagramService.baseUrl; }

    protected form = new diagramForm(this.idPrefix);
}