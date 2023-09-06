import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { diagramGrid } from './diagramGrid';

export default function pageInit() {
    initFullHeightGridPage(new diagramGrid($('#GridDiv')).element);
}