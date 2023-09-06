import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface reviewForm {
    Name: StringEditor;
    Description: StringEditor;
    Subject: StringEditor;
    Email: StringEditor;
}

export class reviewForm extends PrefixedContext {
    static formKey = 'onlinestore.review';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!reviewForm.init)  {
            reviewForm.init = true;

            var w0 = StringEditor;

            initFormType(reviewForm, [
                'Name', w0,
                'Description', w0,
                'Subject', w0,
                'Email', w0
            ]);
        }
    }
}