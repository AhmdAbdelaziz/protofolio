import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { productsGrid } from './productsGrid';

export default function pageInit() {
    initFullHeightGridPage(new productsGrid($('#GridDiv')).element);
}