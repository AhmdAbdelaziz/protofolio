import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface categoryForm {
    Name: StringEditor;
    Photo: StringEditor;
    Description: StringEditor;
}

export class categoryForm extends PrefixedContext {
    static formKey = 'onlinestore.category';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!categoryForm.init)  {
            categoryForm.init = true;

            var w0 = StringEditor;

            initFormType(categoryForm, [
                'Name', w0,
                'Photo', w0,
                'Description', w0
            ]);
        }
    }
}