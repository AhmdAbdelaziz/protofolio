import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { cartGrid } from './cartGrid';

export default function pageInit() {
    initFullHeightGridPage(new cartGrid($('#GridDiv')).element);
}