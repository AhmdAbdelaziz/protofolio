import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface diagramForm {
    Name: StringEditor;
    PrincipalId: IntegerEditor;
    Version: IntegerEditor;
    Definition: StringEditor;
}

export class diagramForm extends PrefixedContext {
    static formKey = 'onlinestore.diagram';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!diagramForm.init)  {
            diagramForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(diagramForm, [
                'Name', w0,
                'PrincipalId', w1,
                'Version', w1,
                'Definition', w0
            ]);
        }
    }
}