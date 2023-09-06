import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { categoryGrid } from './categoryGrid';

export default function pageInit() {
    initFullHeightGridPage(new categoryGrid($('#GridDiv')).element);
}