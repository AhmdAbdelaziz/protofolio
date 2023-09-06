import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { reviewGrid } from './reviewGrid';

export default function pageInit() {
    initFullHeightGridPage(new reviewGrid($('#GridDiv')).element);
}