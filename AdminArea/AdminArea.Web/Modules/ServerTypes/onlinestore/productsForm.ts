import { StringEditor, DecimalEditor, IntegerEditor, LookupEditor, ImageUploadEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface productsForm {
    Name: StringEditor;
    Price: DecimalEditor;
    Description: StringEditor;
    Code: IntegerEditor;
    CategoryId: LookupEditor;
    Photo: ImageUploadEditor;
    SupplierName: StringEditor;
    EntryDate: DateEditor;
    ReviewUrl: StringEditor;
    Quantity: IntegerEditor;
}

export class productsForm extends PrefixedContext {
    static formKey = 'onlinestore.products';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!productsForm.init)  {
            productsForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = IntegerEditor;
            var w3 = LookupEditor;
            var w4 = ImageUploadEditor;
            var w5 = DateEditor;

            initFormType(productsForm, [
                'Name', w0,
                'Price', w1,
                'Description', w0,
                'Code', w2,
                'CategoryId', w3,
                'Photo', w4,
                'SupplierName', w0,
                'EntryDate', w5,
                'ReviewUrl', w0,
                'Quantity', w2
            ]);
        }
    }
}