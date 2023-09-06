import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface productimageForm {
    ProductId: IntegerEditor;
    Image: StringEditor;
}

export class productimageForm extends PrefixedContext {
    static formKey = 'onlinestore.productimage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!productimageForm.init)  {
            productimageForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(productimageForm, [
                'ProductId', w0,
                'Image', w1
            ]);
        }
    }
}