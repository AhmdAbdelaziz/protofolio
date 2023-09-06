import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { productimageGrid } from './productimageGrid';

export default function pageInit() {
    initFullHeightGridPage(new productimageGrid($('#GridDiv')).element);
}