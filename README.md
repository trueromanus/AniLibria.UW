# AniLibria.UW
AniLibria.UW port of original application [Anilibria](https://github.com/anilibria/anilibria-win) on net9.

## What need to do for modernize application
- Remove all warnings (now there are 604 of them)
- Remove LiteDB and remake all cache on simple JSON files
- Update all dependencies
- Remake all ViewModels from `{Binding}` to `{x:Bind}`
- Make support NativeAot compilation
